-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, weight, score, label) VALUES ('fallback', 51.71, 46.21, 'primary');
INSERT INTO layout_items (region, weight, score, label) VALUES ('staging', 74.46, 87.65, 'open');
