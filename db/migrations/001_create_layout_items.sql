-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, level, state) VALUES (52, 57.38, 45, 'primary');
INSERT INTO layout_items (count, ratio, level, state) VALUES (35, 11.04, 91, 'open');
INSERT INTO layout_items (count, ratio, level, state) VALUES (30, 93.72, 23, 'edge');
