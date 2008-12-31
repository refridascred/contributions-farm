-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, state, owner, weight) VALUES ('strict', 'stable', 'edge', 91.24);
INSERT INTO layout_items (token, state, owner, weight) VALUES ('blue', 'eu-west', 'eu-west', 63.87);
INSERT INTO layout_items (token, state, owner, weight) VALUES ('legacy', 'eu-west', 'blue', 12.83);
