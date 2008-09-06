-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, active, state, level) VALUES (55, 58, 'standard', 24);
INSERT INTO layout_items (count, active, state, level) VALUES (53, 39, 'fallback', 81);
INSERT INTO layout_items (count, active, state, level) VALUES (78, 81, 'local', 47);
