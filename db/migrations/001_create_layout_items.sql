-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, region, state, ratio) VALUES ('legacy', 'eu-west', 'green', 0.62);
INSERT INTO layout_items (owner, region, state, ratio) VALUES ('open', 'staging', 'green', 29.48);
