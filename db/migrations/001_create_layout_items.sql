-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, owner, count) VALUES ('staging', 'eu-west', 14);
INSERT INTO layout_items (state, owner, count) VALUES ('latest', 'edge', 63);
INSERT INTO layout_items (state, owner, count) VALUES ('local', 'blue', 73);
