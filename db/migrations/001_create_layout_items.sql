-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, state, weight, active) VALUES (2, 'local', 24.27, 78);
INSERT INTO layout_items (level, state, weight, active) VALUES (74, 'green', 66.56, 4);
INSERT INTO layout_items (level, state, weight, active) VALUES (28, 'cached', 24.39, 94);
