-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, region, token, score) VALUES (5.48, 'standard', 'stable', 80.66);
INSERT INTO layout_items (ratio, region, token, score) VALUES (28.66, 'fallback', 'eu-west', 69.09);
INSERT INTO layout_items (ratio, region, token, score) VALUES (23.34, 'local', 'eu-west', 11.19);
