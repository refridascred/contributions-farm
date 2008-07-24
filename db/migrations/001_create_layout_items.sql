-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, region, rank, token) VALUES (94.63, 'legacy', 1, 'green');
INSERT INTO layout_items (score, region, rank, token) VALUES (19.7, 'open', 97, 'eu-west');
