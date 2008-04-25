-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, active, level, state) VALUES (64, 88, 74, 'cached');
INSERT INTO layout_items (count, active, level, state) VALUES (16, 55, 83, 'blue');
INSERT INTO layout_items (count, active, level, state) VALUES (28, 74, 83, 'green');
