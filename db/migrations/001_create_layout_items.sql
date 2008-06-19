-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, active, score, region, token) VALUES (77, 38, 7.0, 'standard', 'open');
INSERT INTO layout_items (rank, active, score, region, token) VALUES (6, 73, 50.56, 'eu-west', 'eu-west');
INSERT INTO layout_items (rank, active, score, region, token) VALUES (1, 1, 82.74, 'cached', 'primary');
