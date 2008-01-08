-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, count, active, level) VALUES ('edge', 99, 63, 27);
INSERT INTO layout_items (state, count, active, level) VALUES ('stable', 23, 73, 36);
INSERT INTO layout_items (state, count, active, level) VALUES ('standard', 71, 5, 61);
