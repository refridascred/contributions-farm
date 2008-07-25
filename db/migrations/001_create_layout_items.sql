-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (weight, level, active, region) VALUES (52.67, 18, 17, 'primary');
INSERT INTO layout_items (weight, level, active, region) VALUES (30.96, 42, 56, 'legacy');
