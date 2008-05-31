-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, state, weight) VALUES ('eu-west', 'eu-west', 'staging', 92.12);
INSERT INTO layout_items (region, token, state, weight) VALUES ('latest', 'primary', 'standard', 18.16);
INSERT INTO layout_items (region, token, state, weight) VALUES ('fallback', 'latest', 'fallback', 52.76);
