-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, region, token, owner) VALUES ('local', 'strict', 'latest', 'cached');
INSERT INTO layout_items (state, region, token, owner) VALUES ('primary', 'eu-west', 'open', 'green');
