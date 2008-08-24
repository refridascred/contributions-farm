-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, state, active, owner, ratio) VALUES (57, 'latest', 19, 'standard', 19.05);
INSERT INTO layout_items (level, state, active, owner, ratio) VALUES (31, 'strict', 13, 'stable', 64.96);
INSERT INTO layout_items (level, state, active, owner, ratio) VALUES (51, 'open', 34, 'stable', 23.53);
