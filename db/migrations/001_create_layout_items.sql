-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, owner) VALUES ('cached', 'blue', 'local');
INSERT INTO layout_items (region, state, owner) VALUES ('eu-west', 'edge', 'eu-west');
