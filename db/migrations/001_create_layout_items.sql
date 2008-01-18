-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, label, state) VALUES (4.98, 'fallback', 'blue');
INSERT INTO layout_items (ratio, label, state) VALUES (3.23, 'open', 'green');
INSERT INTO layout_items (ratio, label, state) VALUES (56.89, 'standard', 'blue');
