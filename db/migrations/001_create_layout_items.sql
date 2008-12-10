-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, token, region, label, active) VALUES ('legacy', 'blue', 'edge', 'open', 96);
INSERT INTO layout_items (state, token, region, label, active) VALUES ('blue', 'strict', 'eu-west', 'eu-west', 2);
INSERT INTO layout_items (state, token, region, label, active) VALUES ('standard', 'fallback', 'staging', 'blue', 23);
