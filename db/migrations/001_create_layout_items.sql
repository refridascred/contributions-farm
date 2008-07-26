-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, label) VALUES ('eu-west', 44.3, 'staging');
INSERT INTO layout_items (state, ratio, label) VALUES ('edge', 27.53, 'edge');
