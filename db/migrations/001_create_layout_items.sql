-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, label, region) VALUES ('strict', 'fallback', 'standard', 'local');
INSERT INTO layout_items (owner, state, label, region) VALUES ('stable', 'eu-west', 'edge', 'local');
INSERT INTO layout_items (owner, state, label, region) VALUES ('stable', 'staging', 'open', 'green');
