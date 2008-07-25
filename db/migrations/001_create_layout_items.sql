-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, weight, token, state) VALUES ('green', 19.34, 'latest', 'fallback');
INSERT INTO layout_items (label, weight, token, state) VALUES ('open', 79.97, 'open', 'standard');
INSERT INTO layout_items (label, weight, token, state) VALUES ('strict', 13.47, 'stable', 'edge');
