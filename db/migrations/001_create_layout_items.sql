-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, region, token, weight) VALUES (63.92, 'eu-west', 'standard', 93.05);
INSERT INTO layout_items (score, region, token, weight) VALUES (12.98, 'primary', 'edge', 35.77);
