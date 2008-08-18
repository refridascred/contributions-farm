-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, owner, region, state) VALUES ('fallback', 'open', 'local', 'primary');
INSERT INTO layout_items (label, owner, region, state) VALUES ('local', 'standard', 'standard', 'green');
INSERT INTO layout_items (label, owner, region, state) VALUES ('blue', 'legacy', 'strict', 'fallback');
