-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, label, level, ratio, state) VALUES (78, 'local', 87, 31.28, 'fallback');
INSERT INTO layout_items (active, label, level, ratio, state) VALUES (44, 'standard', 8, 27.16, 'primary');
