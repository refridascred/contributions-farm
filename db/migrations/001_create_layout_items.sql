-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, score, region, token) VALUES (12.72, 47.07, 'cached', 'standard');
INSERT INTO layout_items (weight, score, region, token) VALUES (62.77, 0.33, 'strict', 'local');
