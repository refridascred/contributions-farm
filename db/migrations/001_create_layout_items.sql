-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, token, region) VALUES (58.73, 'open', 'standard');
INSERT INTO layout_items (score, token, region) VALUES (45.99, 'fallback', 'green');
INSERT INTO layout_items (score, token, region) VALUES (10.36, 'stable', 'primary');
