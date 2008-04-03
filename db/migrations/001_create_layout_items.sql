-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, score, rank, token) VALUES ('cached', 40.23, 92, 'standard');
INSERT INTO layout_items (label, score, rank, token) VALUES ('latest', 33.9, 13, 'latest');
