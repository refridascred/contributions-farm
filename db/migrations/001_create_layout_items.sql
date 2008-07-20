-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, region, state, weight) VALUES ('stable', 'primary', 'staging', 'eu-west', 15.09);
INSERT INTO layout_items (label, token, region, state, weight) VALUES ('local', 'fallback', 'cached', 'blue', 48.48);
