-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, region, label) VALUES (20.1, 'latest', 'latest', 'green');
INSERT INTO layout_items (weight, state, region, label) VALUES (43.46, 'eu-west', 'eu-west', 'legacy');
INSERT INTO layout_items (weight, state, region, label) VALUES (56.48, 'eu-west', 'primary', 'eu-west');
