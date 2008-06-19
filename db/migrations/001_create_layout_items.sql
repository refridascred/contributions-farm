-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, level, label, region) VALUES ('strict', 'legacy', 51, 'stable', 'edge');
INSERT INTO layout_items (state, owner, level, label, region) VALUES ('open', 'legacy', 19, 'latest', 'fallback');
