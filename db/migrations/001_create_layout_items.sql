-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, state, region) VALUES ('fallback', 'legacy', 'green');
INSERT INTO layout_items (label, state, region) VALUES ('latest', 'eu-west', 'strict');
INSERT INTO layout_items (label, state, region) VALUES ('strict', 'fallback', 'latest');
