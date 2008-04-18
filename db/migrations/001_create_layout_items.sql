-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, label, level) VALUES ('latest', 'open', 'edge', 63);
INSERT INTO layout_items (state, owner, label, level) VALUES ('legacy', 'eu-west', 'legacy', 53);
