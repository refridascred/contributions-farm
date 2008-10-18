-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, owner, weight, score, region) VALUES (18, 'fallback', 48.0, 58.95, 'legacy');
INSERT INTO layout_items (count, owner, weight, score, region) VALUES (75, 'standard', 35.01, 80.82, 'blue');
