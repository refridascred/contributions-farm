-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner, active, state) VALUES (84.63, 'open', 88, 'blue');
INSERT INTO layout_items (ratio, owner, active, state) VALUES (44.04, 'legacy', 23, 'strict');
INSERT INTO layout_items (ratio, owner, active, state) VALUES (67.63, 'open', 68, 'green');
