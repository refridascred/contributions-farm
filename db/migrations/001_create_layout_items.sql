-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label, weight, state) VALUES (38, 'latest', 72.07, 'eu-west');
INSERT INTO layout_items (level, label, weight, state) VALUES (93, 'staging', 20.82, 'edge');
