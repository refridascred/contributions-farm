-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, token, state) VALUES ('standard', 24, 'fallback', 'standard');
INSERT INTO layout_items (region, rank, token, state) VALUES ('eu-west', 59, 'standard', 'edge');
INSERT INTO layout_items (region, rank, token, state) VALUES ('strict', 24, 'stable', 'eu-west');
