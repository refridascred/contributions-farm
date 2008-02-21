-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, score, rank, token) VALUES ('eu-west', 47.26, 37, 'standard');
INSERT INTO layout_items (region, score, rank, token) VALUES ('open', 4.46, 4, 'latest');
INSERT INTO layout_items (region, score, rank, token) VALUES ('cached', 46.58, 18, 'cached');
