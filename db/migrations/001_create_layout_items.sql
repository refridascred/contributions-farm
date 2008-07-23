-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, region, level, active, count) VALUES ('open', 'blue', 86, 24, 5);
INSERT INTO layout_items (label, region, level, active, count) VALUES ('cached', 'strict', 78, 46, 44);
INSERT INTO layout_items (label, region, level, active, count) VALUES ('open', 'edge', 38, 93, 99);
