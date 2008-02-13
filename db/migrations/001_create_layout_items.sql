-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, active, region, weight, level) VALUES ('primary', 89, 'primary', 38.18, 69);
INSERT INTO layout_items (label, active, region, weight, level) VALUES ('green', 1, 'eu-west', 4.72, 92);
