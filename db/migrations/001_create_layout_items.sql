-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, owner, region, token, state) VALUES ('legacy', 'staging', 'green', 'open', 'fallback');
INSERT INTO layout_items (label, owner, region, token, state) VALUES ('primary', 'eu-west', 'fallback', 'green', 'stable');
