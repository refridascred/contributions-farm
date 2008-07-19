-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, level, ratio, score) VALUES ('edge', 2, 4.57, 48.15);
INSERT INTO layout_items (region, level, ratio, score) VALUES ('standard', 42, 75.56, 97.5);
