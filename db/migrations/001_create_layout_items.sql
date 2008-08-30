-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, label, weight, score) VALUES ('fallback', 'green', 87.78, 24.51);
INSERT INTO layout_items (region, label, weight, score) VALUES ('standard', 'cached', 45.06, 14.6);
