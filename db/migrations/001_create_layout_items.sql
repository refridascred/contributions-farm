-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, state, ratio) VALUES ('eu-west', 'blue', 4.18);
INSERT INTO layout_items (owner, state, ratio) VALUES ('primary', 'fallback', 94.79);
INSERT INTO layout_items (owner, state, ratio) VALUES ('fallback', 'staging', 36.13);
