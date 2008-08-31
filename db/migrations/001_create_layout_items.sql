-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, label, state) VALUES ('latest', 54.35, 'cached', 'staging');
INSERT INTO layout_items (token, weight, label, state) VALUES ('staging', 87.4, 'primary', 'local');
INSERT INTO layout_items (token, weight, label, state) VALUES ('blue', 23.96, 'edge', 'edge');
