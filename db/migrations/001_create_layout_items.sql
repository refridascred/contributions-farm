-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, ratio, state) VALUES (5, 99, 63.75, 'blue');
INSERT INTO layout_items (count, level, ratio, state) VALUES (25, 11, 24.67, 'open');
INSERT INTO layout_items (count, level, ratio, state) VALUES (0, 94, 60.23, 'stable');
