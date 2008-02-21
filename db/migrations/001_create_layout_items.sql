-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, active, label, ratio, weight) VALUES ('strict', 39, 'legacy', 35.47, 60.72);
INSERT INTO layout_items (region, active, label, ratio, weight) VALUES ('cached', 63, 'open', 66.62, 73.9);
