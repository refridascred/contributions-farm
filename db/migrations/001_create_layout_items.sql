-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, active, region, ratio) VALUES (43, 62, 'primary', 43.94);
INSERT INTO layout_items (level, active, region, ratio) VALUES (46, 32, 'strict', 22.03);
INSERT INTO layout_items (level, active, region, ratio) VALUES (92, 84, 'standard', 27.74);
