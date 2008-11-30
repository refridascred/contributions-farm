-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (state, region, label, owner) VALUES ('staging', 'edge', 'edge', 'local');
INSERT INTO layout_items (state, region, label, owner) VALUES ('standard', 'stable', 'cached', 'edge');
INSERT INTO layout_items (state, region, label, owner) VALUES ('latest', 'staging', 'cached', 'staging');
