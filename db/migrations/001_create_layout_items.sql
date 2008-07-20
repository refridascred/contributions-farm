-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, count, owner, state) VALUES (96.02, 1, 'stable', 'stable');
INSERT INTO layout_items (ratio, count, owner, state) VALUES (0.59, 64, 'open', 'stable');
INSERT INTO layout_items (ratio, count, owner, state) VALUES (57.31, 51, 'local', 'primary');
