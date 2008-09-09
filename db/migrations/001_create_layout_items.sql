-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, level, region, weight, active) VALUES (0.26, 41, 'staging', 27.37, 89);
INSERT INTO layout_items (score, level, region, weight, active) VALUES (2.25, 68, 'eu-west', 90.6, 59);
