-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, active, state) VALUES ('open', 90, 'primary');
INSERT INTO layout_items (owner, active, state) VALUES ('cached', 36, 'primary');
INSERT INTO layout_items (owner, active, state) VALUES ('strict', 94, 'cached');
