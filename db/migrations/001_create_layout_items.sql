-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, region, score, weight, label) VALUES (50, 'staging', 26.66, 54.62, 'fallback');
INSERT INTO layout_items (level, region, score, weight, label) VALUES (64, 'standard', 3.45, 77.81, 'blue');
