-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, active, label, region) VALUES (82, 61, 'standard', 'strict');
INSERT INTO layout_items (level, active, label, region) VALUES (22, 93, 'edge', 'strict');
INSERT INTO layout_items (level, active, label, region) VALUES (85, 19, 'edge', 'fallback');
