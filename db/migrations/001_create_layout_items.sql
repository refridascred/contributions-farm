-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, active) VALUES ('cached', 'strict', 18);
INSERT INTO layout_items (state, owner, active) VALUES ('stable', 'legacy', 29);
INSERT INTO layout_items (state, owner, active) VALUES ('staging', 'green', 99);
