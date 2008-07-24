-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, active, token, owner, state) VALUES ('eu-west', 93, 'fallback', 'open', 'primary');
INSERT INTO layout_items (region, active, token, owner, state) VALUES ('strict', 95, 'cached', 'fallback', 'edge');
