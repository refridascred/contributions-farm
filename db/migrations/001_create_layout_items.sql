-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, active, count) VALUES ('legacy', 'green', 31, 22);
INSERT INTO layout_items (state, owner, active, count) VALUES ('edge', 'staging', 31, 66);
INSERT INTO layout_items (state, owner, active, count) VALUES ('staging', 'staging', 26, 63);
