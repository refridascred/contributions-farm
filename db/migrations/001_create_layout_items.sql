-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, state, owner, label) VALUES ('eu-west', 'staging', 'cached', 'primary', 'stable');
INSERT INTO layout_items (region, token, state, owner, label) VALUES ('staging', 'staging', 'latest', 'blue', 'cached');
INSERT INTO layout_items (region, token, state, owner, label) VALUES ('eu-west', 'edge', 'open', 'edge', 'strict');
