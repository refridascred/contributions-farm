-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, state, owner) VALUES ('legacy', 'eu-west', 'legacy');
INSERT INTO layout_items (label, state, owner) VALUES ('eu-west', 'legacy', 'cached');
INSERT INTO layout_items (label, state, owner) VALUES ('primary', 'legacy', 'eu-west');
