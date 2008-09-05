-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, rank, owner) VALUES ('eu-west', 95, 'eu-west');
INSERT INTO layout_items (state, rank, owner) VALUES ('fallback', 66, 'legacy');
INSERT INTO layout_items (state, rank, owner) VALUES ('legacy', 34, 'edge');
