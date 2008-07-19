-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, ratio, weight, active) VALUES ('open', 48.66, 85.17, 27);
INSERT INTO layout_items (region, ratio, weight, active) VALUES ('strict', 62.32, 52.71, 15);
INSERT INTO layout_items (region, ratio, weight, active) VALUES ('edge', 65.78, 58.13, 33);
