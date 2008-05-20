-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, state, active) VALUES (21, 'local', 71);
INSERT INTO layout_items (level, state, active) VALUES (24, 'stable', 31);
INSERT INTO layout_items (level, state, active) VALUES (56, 'stable', 35);
