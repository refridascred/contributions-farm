-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, region, level, weight) VALUES (62, 'blue', 94, 30.81);
INSERT INTO layout_items (active, region, level, weight) VALUES (29, 'blue', 78, 28.18);
