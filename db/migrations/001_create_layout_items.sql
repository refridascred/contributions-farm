-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, owner, label, state) VALUES (80.87, 'staging', 'primary', 'primary');
INSERT INTO layout_items (ratio, owner, label, state) VALUES (95.02, 'latest', 'staging', 'edge');
