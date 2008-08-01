-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, region, token, state) VALUES ('cached', 'cached', 'cached', 'latest');
INSERT INTO layout_items (label, region, token, state) VALUES ('legacy', 'staging', 'stable', 'latest');
INSERT INTO layout_items (label, region, token, state) VALUES ('edge', 'green', 'fallback', 'local');
